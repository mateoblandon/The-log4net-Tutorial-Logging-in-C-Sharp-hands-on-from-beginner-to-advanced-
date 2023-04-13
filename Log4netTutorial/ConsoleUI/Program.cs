﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace ConsoleUI
{
  class Program
  {
    public static readonly log4net.ILog log = LogHelper.GetLogger(); //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    static void Main(string[] args)
    {
      log.Debug("Developer: tutorial was fun");
      log.Info("Maintenance: water pump turned on");
      log.Warn("Maintenance: water pump is getting hot");
      var i = 0;
      try { var x = 10 / i; } 
      catch (DivideByZeroException ex) {  log.Error("Developer: we tried to divide by zero again", ex); }
      log.Fatal("Maintenance: water pump exploded");
      Console.ReadLine();
    }
  }
}
