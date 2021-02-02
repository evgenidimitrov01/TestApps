using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddDynamicElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Err(string mess)
        {
            MessageBox.Show(mess, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                flp.Controls.Clear();
                decimal WaterMeterStart, WaterMeterEnd, WaterMeterDifference, Step;
                int days;
                WaterMeterStart = decimal.Parse(txtWaterMeterStart.Text);
                WaterMeterEnd = decimal.Parse(txtWaterMeterEnd.Text);
                if (!int.TryParse(txtDays.Text, out days))
                {
                    Err("Моля въведете дни!");
                    return;
                }

                if (WaterMeterEnd <= WaterMeterStart)
                {
                    Err("Крайната мярка не може да бъде по-малка от началната!");
                    return;
                }

                WaterMeterDifference = WaterMeterEnd - WaterMeterStart;
                Step = WaterMeterDifference / days;

                decimal[] forDays = new decimal[days + 1];
                decimal j = 0;
                for (int i = 1; i <= days; i++)
                {
                    j = WaterMeterStart += Step;
                    j = Math.Round(j, 3);
                    forDays[i] = (i / 2 == 0) ? j + 0.003m : j - 0.001m;
                    if ((forDays[days] > WaterMeterEnd) || (forDays[days] < WaterMeterEnd))
                    {
                        forDays[days] = WaterMeterEnd;
                    }
                    flp.Controls.Add(MakeLabel("За ден: " + i + " - " + forDays[i]));
                }
            }
            catch (Exception ex)
            {
                Err(ex.Message);
            }
        }

        Label MakeLabel(string text)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Size = new System.Drawing.Size(70, 13);
            label.Text = text;
            return label;
        }
    }
}
