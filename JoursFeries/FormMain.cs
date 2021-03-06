﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Itenso.TimePeriod;


namespace JoursFeries
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private TimeRange CurrentYearRange;
    private const string CountryListFileName = @"ListOfCountries.xml";


    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      labelJourFerie.Text = dateTimePicker1.Value.ToLongDateString() + " est férié ou pas";
    }

    private bool IsBankHoliday(DateTime oneDay, string country = "France")
    {
      //read xml file
      //TODO

      return false;
    }

    private int HowManyBankHoliday(ITimePeriod timePeriod, string country = "France")
    {
      //read xml file
      //TODO
      return 0;
    }

    private bool HasABankholidayIn(ITimePeriod timePeriod, string country = "France")
    {
      // search if one or many bank holidays are inside a time period
      //TODO
      return false;
    }

    private bool HasABankholidayIn(TimeSpan timePeriod, string country = "France")
    {
      // search if one or many bank holidays are inside a time period
      //TODO
      return false;
    }

    private int HowManyWorkingDays(TimeSpan timeSpan, string country = "France")
    {
      // TODO
      return 0;
    }

    private int HowManyWorkingHours(TimeSpan periodTimeSpan, Time startWorkingHour, Time endWorkingTime, string country = "France")
    {
      // TODO
      return 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CurrentYearRange = new TimeRange(new DateTime(DateTime.Now.Year, 1, 1), new DateTime(DateTime.Now.Year, 12, 31));
      //loading country list to comboBoxCountryList
      foreach (string countryName in LoadCountries(CountryListFileName))
      {
        comboBoxCountryList.Items.Add(countryName);
      }

      if (comboBoxCountryList.Items.Count > 0)
      {
        comboBoxCountryList.SelectedIndex = 0;
      }

    }

    private static IEnumerable<string> LoadCountries(string filename)
    {
      if (!File.Exists(filename))
      {
        using (StreamWriter sw = new StreamWriter(filename))
        {
          sw.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?>""");
          sw.WriteLine(@"<countries>");
          sw.WriteLine(@" <country>France</country>");
          sw.WriteLine(@" <country>United States of America</country>");
          sw.WriteLine(@" <country>Spain</country>");
          sw.WriteLine(@" <country>Italy</country>");
          sw.WriteLine(@" <country>Germany</country>");
          sw.WriteLine(@" <country>Netherlands</country>");
          sw.WriteLine(@" <country>United Kingdom</country>");
          sw.WriteLine(@"</countries>");
        }
      }

      List<string> result = new List<string>();
      XmlTextReader reader = new XmlTextReader(filename);

      while (reader.Read())
      {
        if (reader.NodeType == XmlNodeType.Element && reader.Name == "country")
        {
          if (reader.HasAttributes)
          {
            result.Add(reader.GetAttribute("name"));
          }
        }
      }

      return result.Count != 0 ? result : new List<string> { "France" };
    }
  }
}