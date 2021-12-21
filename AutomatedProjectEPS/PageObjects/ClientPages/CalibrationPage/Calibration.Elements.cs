using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Calibration
    {
        public IWebElement cbbxBinaries => Browser._Driver.FindElement(_cbbxBinaries);
        public readonly By _cbbxBinaries = By.XPath("//*[contains(@AutomationId, 'BinariesCbbx')]");

        public IWebElement cbbxCalibrations => Browser._Driver.FindElement(_cbbxCalibrations);
        public readonly By _cbbxCalibrations = By.XPath("//*[contains(@AutomationId, 'CalibrationsCbbx')]");

        public IWebElement btnConfirmEcuInformation => Browser._Driver.FindElement(_btnConfirmEcuInformation);
        public readonly By _btnConfirmEcuInformation = By.XPath("//*[contains(@AutomationId, 'ConfirmEcuInformationBtn')]");





        // ONLY OEM
        public IWebElement btnCalibrate => Browser._Driver.FindElement(_btnCalibrate);
        public readonly By _btnCalibrate = By.XPath("//*[contains(@AutomationId, 'PopupCalibrateBtn')]");


        //OEM  listbox with Ecus
        public IWebElement lbEcus => Browser._Driver.FindElement(_lbEcus);
        public readonly By _lbEcus = By.XPath("//*[contains(@AutomationId, 'EcusLb')]");

        public IWebElement tbEcuName => Browser._Driver.FindElement(_tbEcuName);
        public readonly By _tbEcuName = By.XPath("//*[contains(@AutomationId, 'tb_EcuName')]");




        //OEM  listbox with Calibrations
        public IWebElement lbCalibrations => Browser._Driver.FindElement(_lbCalibrations);
        public readonly By _lbCalibrations = By.XPath("//*[contains(@AutomationId, 'CalibrationsLb')]");  //Name - e.g.'Serie emulation'         ClassName - ListBoxItem

        public IWebElement tbCalibrationName => Browser._Driver.FindElement(_tbCalibrationName);
        public readonly By _tbCalibrationName = By.XPath("//*[contains(@AutomationId, 'CalibrationNameTb')]");     //Name - e.g.'Perf'       ClassName - ListBoxItem

    }
}
