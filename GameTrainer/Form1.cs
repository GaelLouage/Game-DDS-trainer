using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameTrainer
{
    public partial class Form1 : Form
    {
        // gebruik toetsen (pinvoke)
        //attribute
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        // kijk of game in x64 of x86 is
        // instance memory.dll
        public Mem myMem = new Mem();
        private bool processOpen = false;
        private const string gameNameExe = "DrugDealerSimulator-Win64-Shipping.exe";
        private const string level = gameNameExe + "+02BEEED0,2a0,aa0,358,348";
        private const string orderLimit = "DrugDealerSimulator-Win64-Shipping.exe+02BEEED0,2a0,aa0,360,510";
        private const string backpackItemOne = gameNameExe + "+02F25D58,970,158,18,36C";
        private const string skillPoints = gameNameExe + "+02BEEED0,2d0,78,aa0,358,3bc";
        // position list
        private List<string> positionPlayer = new List<string>()
        {
            //y
            gameNameExe +"+02BEEED0,2b8,398,194",
            //x
             gameNameExe +"+02BEEED0,2b8,158,190",
            //z
             gameNameExe +"+02BEEED0,2b8,398,198"
        };
        // memory reputation
        private List<string> reputationValues = new List<string>()
                    {
                        // west old town
                       gameNameExe + "+02BEEED0,270,aa0,698,158,20,368,0",
                        // east old town
                       gameNameExe + "+02BEEED0,378,aa0,698,78,368,4",
                        // two tower
                       gameNameExe + "+02BEEED0,2d0,78,70,b0,150,350,248",
                        // old marketplace
                        gameNameExe + "+02BEEED0,3c0,140,70,b0,150,350,24c"
                    };
        public Form1()
        {
            InitializeComponent();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // dit is een boolean
            processOpen = myMem.OpenProcess(gameNameExe);
            // kijkt of mijn process beschikbaar is (! niet open)
            if (!processOpen)
            {
                // rest van code niet uitvoeren
                MessageBox.Show("Process not running.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } else
            {
                // oneindige lust zodat gegevens gelezen worden
                while (true)
                {
                    // verwijder check for illegale thread op andere thread
                    CheckForIllegalCrossThreadCalls = false;
                    ReadUpdateValuesAsync();
                    BGWorker.ReportProgress(0);
                    Thread.Sleep(1000);
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }
        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // als mijn process open is (game naam)
            Thread.Sleep(150);
            if (processOpen)
            {
                lblProcess.Text = $"Process: {gameNameExe}";
            }
            else
            {
                lblProcess.Text = $"Process: {processOpen.ToString()}";
            }
        }
        private void btnOrderLimit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtOrderLimit.Text))
                {
                    if (double.TryParse(txtOrderLimit.Text, out _))
                    {
                        myMem.WriteMemory(orderLimit, "float", txtOrderLimit.Text);
                        txtOrderLimit.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Value must be numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No value entered.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //********************************************* navigation *****************************************************//
        private void lblReputation_Click(object sender, EventArgs e)
        {
            pnlMisc.Hide();
            pnlPlayer.Hide();
            pnlReputation.Show();
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {
            pnlMisc.Hide();
            pnlReputation.Hide();
            pnlPlayer.Show();
        }

        private void lblMisc_Click(object sender, EventArgs e)
        {
            pnlReputation.Hide();
            pnlPlayer.Hide();
            pnlMisc.Show();
        }
        //************************************************** player section **********************************************//
        // level buttons
        private void btnLevelMin_Click(object sender, EventArgs e)
        {
            try
            {
                int currentLevel = myMem.ReadInt(level);
                  myMem.WriteMemory(level, "int", (currentLevel - 1).ToString());
            }
            catch
            {
                MessageBox.Show("Error writing level memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLevelPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int currentLevel = myMem.ReadInt(level);

                myMem.WriteMemory(level, "int", (currentLevel + 1).ToString());
            }
            catch
            {
                MessageBox.Show("Error writing level memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // skillpoints
        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtSkillPoints.Text, out _))
                {
                    myMem.WriteMemory(skillPoints, "int", txtSkillPoints.Text);
                    txtSkillPoints.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("value must be numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Error writing level memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //************************************************** reputation section ***************************************//
        private void tbWestOldTown_Scroll(object sender, EventArgs e)
        {
            float westOld = tbWestOldTown.Value;
            WriteRepAsync(reputationValues[0], westOld);
        }

        private void tbEastOldTown_Scroll(object sender, EventArgs e)
        {
            float eastOld = tbEastOldTown.Value;
            WriteRepAsync(reputationValues[1], eastOld);
        }

        private void tbTwoTowers_Scroll(object sender, EventArgs e)
        {
            float twoTowers = tbTwoTowers.Value;
            WriteRepAsync(reputationValues[2], twoTowers);
        }

        private void tbOldMarketPlace_Scroll(object sender, EventArgs e)
        {
            float oldMarket = tbOldMarketPlace.Value;
            WriteRepAsync(reputationValues[3], oldMarket);
        }

        //******************************************************* my methods *******************************************************//
        private async void WriteRepAsync(string memory, float value)
        {
            await WriteReputationTrackBarsAsync(memory, value);
        }
        private async Task WriteReputationTrackBarsAsync(string memory, float value)
        {
            await Task.Run(() =>
            {
                try
                {
                    myMem.WriteMemory(memory, "float", value.ToString());
                }
                catch
                {
                    MessageBox.Show("Error reading memory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        public async void ReadUpdateValuesAsync()
        {
            await UpdateValuesAsync();
        }
        public async Task UpdateValuesAsync()
        {
            await Task.Run(() =>
            {
                try
                {
                    // teleport
                    if (GetAsyncKeyState(Keys.F1) < -1)
                    {
                        // house
                        Teleport("-500", "-1046", "842");
                    }
                    else if (GetAsyncKeyState(Keys.F2) < -1)
                    {
                        // jamies shop
                        Teleport("11941", "-5171", "200");
                    }
                    else if (GetAsyncKeyState(Keys.F3) < -1)
                    {
                        //west old town
                        Teleport("-7830", "2362", "520");
                    }
                    else if (GetAsyncKeyState(Keys.F4) < -1)
                    {
                        // kennel
                        Teleport("10000", "-5171", "200");
                    }
                    else if (GetAsyncKeyState(Keys.Escape) < -1)
                    {
                        this.Hide();
                    }
                    else if (GetAsyncKeyState(Keys.Insert) < -1)
                    {
                        this.Show();
                    }
                    pgBarWestOldTown.Value = (int)myMem.ReadFloat(reputationValues[0]);
                    pgBarEastOldTown.Value = (int)myMem.ReadFloat(reputationValues[1]);
                    pgbTwoTowers.Value = (int)myMem.ReadFloat(reputationValues[2]);
                    pgbOldMarketPlace.Value = (int)myMem.ReadFloat(reputationValues[3]);
                    lblWestOldTown.Text = myMem.ReadFloat(reputationValues[0]).ToString("F0");
                    lblEastoldTown.Text = myMem.ReadFloat(reputationValues[1]).ToString("F0");
                    lblTwoTowers.Text = myMem.ReadFloat(reputationValues[2]).ToString("F0");
                    lblOldMarketPlace.Text = myMem.ReadFloat(reputationValues[3]).ToString("F0");
                    tbWestOldTown.Value = (int)myMem.ReadFloat(reputationValues[0]);
                    tbEastOldTown.Value = (int)myMem.ReadFloat(reputationValues[1]);
                    tbTwoTowers.Value = (int)myMem.ReadFloat(reputationValues[2]);
                    tbOldMarketPlace.Value = (int)myMem.ReadFloat(reputationValues[3]);
                    lblOrderLimit.Text = myMem.ReadFloat(orderLimit).ToString("F0");
                    lblLevel.Text = myMem.ReadInt(level).ToString();
                    if (cbReputation.Checked)
                    {
                        myMem.WriteMemory(reputationValues[0].ToString(), "float", "1000");
                        myMem.WriteMemory(reputationValues[1].ToString(), "float", "1000");
                        myMem.WriteMemory(reputationValues[2].ToString(), "float", "1000");
                        myMem.WriteMemory(reputationValues[3].ToString(), "float", "1000");
                    }
                    // super jump
                    if (cbSuperJump.Checked)
                    {
                        if (GetAsyncKeyState(Keys.Space) < -1)
                        {
                            myMem.WriteMemory("DrugDealerSimulator-Win64-Shipping.exe+02BEEED0,2b8,390,10c", "float", "800");
                        }
                    }
                    // backpack
                    if (cbBPOne.Checked)
                    {
                        myMem.WriteMemory(backpackItemOne, "int", "100");
                    }
                    else if (cbBpTwo.Checked)
                    {
                        myMem.WriteMemory(backpackItemOne, "int", "500");
                    }
                    else if (cbBpThree.Checked)
                    {
                        myMem.WriteMemory(backpackItemOne, "int", "1000");
                    }
                    else if (cbBpFour.Checked)
                    {
                        myMem.WriteMemory(backpackItemOne, "int", "10000");
                    }
                }
                catch
                {
                    // MessageBox.Show("Test");
                }
            });
        }
        // teleport
        private void Teleport(string y, string x, string z)
        {
            myMem.WriteMemory(positionPlayer[0],"float",x);
            myMem.WriteMemory(positionPlayer[1], "float", y);
            myMem.WriteMemory(positionPlayer[2], "float", z);
        }
        // uncheck cboxes
        private void cbBPOne_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBPOne.Checked)
            {
                cbBpTwo.Checked = false;
                cbBpThree.Checked = false;
                cbBpFour.Checked = false;
            }
        }

        private void cbBpThree_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBpThree.Checked)
            {
                cbBPOne.Checked = false;
                cbBpTwo.Checked = false;
                cbBpFour.Checked = false;
            }
        }

        private void cbBpTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBpTwo.Checked)
            {
                cbBpThree.Checked = false;
                cbBPOne.Checked = false;
                cbBpFour.Checked = false;
            }
        }

        private void cbBpFour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBpFour.Checked)
            {
                cbBPOne.Checked = false;
                cbBpTwo.Checked = false;
                cbBpThree.Checked = false;
            }
        }
    }
}
