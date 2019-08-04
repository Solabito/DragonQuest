using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonQuest
{
    public partial class AddCharacterForm : Form
    {
        private string InputName;
        private int InputMaxHP;
        private int InputMaxMP;
        private int InputAttack;
        private int InputDefence;
        private int InputSpeed;
        List<CharacterParameter> Players = new List<CharacterParameter>();
        private int Counter;

        public AddCharacterForm()
        {
            InitializeComponent();
        }

        private void AddCharacterForm_Load(object sender, EventArgs e)
        {
            InputName = NameTextBox.Text;
            InputMaxHP = (Int32)MaxHPUpDown.Value;
            InputMaxMP = (Int32)MaxMPUpDown.Value;
            InputAttack = (Int32)AttackUpDown.Value;
            InputDefence = (Int32)DefenceUpDown.Value;
            InputSpeed = (Int32)SpeedUpDown.Value;
            Counter = 0;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            InputName = NameTextBox.Text;
        }

        private void MaxHPUpDown_ValueChanged(object sender, EventArgs e)
        {
            InputMaxHP = (Int32)MaxHPUpDown.Value;
        }

        private void MaxMPUpDown_ValueChanged(object sender, EventArgs e)
        {
            InputMaxMP = (Int32)MaxMPUpDown.Value;
        }

        private void AttackUpDown_ValueChanged(object sender, EventArgs e)
        {
            InputAttack = (Int32)AttackUpDown.Value;
        }

        private void DefenceUpDown_ValueChanged(object sender, EventArgs e)
        {
            InputDefence = (Int32)DefenceUpDown.Value;
        }

        private void SpeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            InputSpeed = (Int32)SpeedUpDown.Value;
        }

        private void AddCharacterButton_Click(object sender, EventArgs e)
        {
            CharacterParameter tmpPlayer = new CharacterParameter(InputName, InputMaxHP, InputMaxMP, InputAttack, InputDefence, InputSpeed);
            Players.Add(tmpPlayer);

            // confirmation
            for (int i = 0; i < Players.Count; i++)
            {
                Console.WriteLine("");
                Players[i].Damage(100,Players[i].Defence);
                Console.WriteLine(Players[i].Name);
                Console.WriteLine(Players[i].HP+"/"+Players[i].MaxHP);
                Console.WriteLine(Players[i].MaxMP);
                Console.WriteLine(Players[i].Attack);
                Console.WriteLine(Players[i].Defence);
                Console.WriteLine(Players[i].Speed);
            }

        }
    }
}
