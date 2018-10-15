using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace OutputAnalogVoltage
{
    public partial class Form1 : Form
    {
        double voltageValue = 0;

        public Form1()
        {
            InitializeComponent();
            hscVoltageValue.Value = 1000;

            //Fill the comnbo box with the physical channels
            cmbPhysicalChannel.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));

            //Force select dev4/ao0 as the default (on my PC)
            cmbPhysicalChannel.SelectedIndex = 2;
        }

        private void hscVoltageValue_Scroll(object sender, ScrollEventArgs e)
        {
            double Voltage = 0;
            Voltage = (System.Convert.ToDouble(hscVoltageValue.Value) - 1000) / 100;
            lblScrollbarValue.Text = Voltage.ToString("0.00") + "V";

            voltageValue = Voltage;

            UpdateDAQ();
        }

        private void UpdateDAQ()
        {
            Cursor.Current = Cursors.WaitCursor;		//Fancy cursor stuff
            //Try-catch-finally is the error handling we will use.
            try
            {
                using (Task analogWriteTask = new Task())
                {
                    //Create the actual channel. Min: -10V, Max: 10V, Units: V
                    analogWriteTask.AOChannels.CreateVoltageChannel(cmbPhysicalChannel.Text, "", -10, 10, AOVoltageUnits.Volts);
                   
                    //Create a writer
                    AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogWriteTask.Stream);


                    //Use that writer to write a voltage value.
                    writer.WriteSingleSample(true, voltageValue);
                }
            }
            catch (DaqException ex)		// We define ex as a DaqException here.
            {
                MessageBox.Show(ex.Message);	// Shows whatever the exception message is if the TRY fails
            }
            finally		//Return the cursor to its normal state
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            voltageValue = 0;
            UpdateDAQ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
