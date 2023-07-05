using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camping
{
    public partial class Import : Form
    {
        public List<string[]> csvData;
        private const int selectedRecordsMinimum = 1;
        private const int selectedRecordsMaximum = 5;
        private DateTime startDateTax = new DateTime(2023, 07, 11);
        private DateTime endDateTax = new DateTime(2023, 08, 15);
        private List<Spot> spotsList;

        public Import()
        {
            InitializeComponent();
            spotsList = new List<Spot>(); 
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reservationsPage = new ReservationsPage();
            this.Hide();
            reservationsPage.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutPage = new AboutBox1();
            this.Hide();
            aboutPage.Show();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader dataImport = new StreamReader(@"../../data.csv");
                csvData = new List<string[]>();
                SpotsBox.Items.Clear();

                int counter = 0;

                while (!dataImport.EndOfStream)
                {
                    string temp = dataImport.ReadLine();
                    string[] tempArr = temp.Split(';');
                    if (counter > 0)
                    {
                        Spot spot = new Spot(tempArr[0]);
                        csvData.Add(tempArr);
                        SpotsBox.Items.Add($"{tempArr[0]} | {tempArr[1]} | {tempArr[2]} | {tempArr[3]} | {tempArr[4]}");
                        spotsList.Add(spot);
                    }
                    counter++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed: " + ex.Message);
            }
        }

        private void SpotsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox spots = (ListBox)sender;
            if (spots.SelectedItems.Count > selectedRecordsMaximum)
            {
                int lastIndex = spots.SelectedIndices[spots.SelectedItems.Count - 1];

                // Unselect the last item
                spots.SetSelected(lastIndex, false);

                // Remove the last index from the selected items list
                spots.SelectedIndices.Remove(lastIndex);
            }
        }

        private void calculateCosts_Click(object sender, EventArgs e)
        {
            if (startDate != null && endDate != null)
            {
                DateTime startDateInput = DateTime.Parse(startDate.Text);
                DateTime endDateInput = DateTime.Parse(endDate.Text);
                Console.WriteLine(startDateInput + " - " + endDateInput);
                if (endDateInput.CompareTo(startDateInput) > 0)
                {
                    costsBox.Items.Clear();
                    ListBox spots = SpotsBox;
                    if (spots.SelectedItems.Count < selectedRecordsMinimum)
                    {
                        MessageBox.Show($"Selecteer minimaal 1 of maximaal 5 plaatsen");
                    }
                    else
                    {
                        List<string> selectedSpotList = new List<string>();
                        double totalPrice = 0;
                        foreach (var selectedSpot in spots.SelectedItems)
                        {
                            selectedSpotList.Add(selectedSpot.ToString());
                        }

                        foreach (string selectedSpot in selectedSpotList)
                        {
                            string[] spotInfo = selectedSpot.Split('|');
                            string spotName = spotInfo[0];
                            double spotPrice = 15.0;
                            if (spotInfo[1].Contains("true"))
                            {
                                spotPrice += 3.0;
                            }

                            spotPrice += Convert.ToInt32(spotInfo[3]) * 2.5;
                            costsBox.Items.Add($"{spotName} | {spotPrice}");
                            totalPrice += spotPrice;
                        }
                        if (startDateInput.CompareTo(startDateTax) >= 0 && startDateInput.CompareTo(endDateTax) <= 0)
                        {
                            totalPrice *= 1.25;
                        }
                        else if (endDateInput.CompareTo(startDateTax) >= 0 && endDateInput.CompareTo(endDateTax) <= 0)
                        {
                            totalPrice *= 1.25;
                        }

                        costsBox.Items.Add($"Total price: " + totalPrice);
                    }
                }
                else
                {
                    MessageBox.Show("Einddatum moet na de startdatum zijn");
                }
            }
            else
            {
                MessageBox.Show("Gelieve zowel de start- als einddatum in te vullen");
            }
        }
    }
}