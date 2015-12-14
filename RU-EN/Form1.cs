using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RU_EN
{
    public partial class Form1 : Form
    {
        char[] ru ={
'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О',
'П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю',
'Я','\'','0','1','2','3','4','5','6','7','8','9','(',')','?','+',
'№','#','%','&',',','/','-','.',':',' ','!','$',';','\\','|','_',
'=','<','>','[',']','{','}','“','”','«','»','*','@','^','~'};
        char[] en = {
'A','B','V','G','D','E','o','J','Z','I','i','K','L','M','N','O',
'P','R','S','T','U','F','H','C','c','Q','q','x','Y','X','e','u',
'a','j','0','1','2','3','4','5','6','7','8','9','(',')','?','+',
'n','n','p','d',',','/','-','.',':',' ','b','s','v','/','/','z',
'r','(',')','(',')','(',')','m','m','m','m','f','f','f','f'};

        char[] ru1 = {
'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О',
'П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю',
'Я','\'','0','1','2','3','4','5','6','7','8','9','(',')','?','+',
'№','№','%','&',',','/','-','.',':',' ','!','$',';','/','/','_',
'=','(',')','(',')','(',')','”','”','”','”','*','*','*','*'};
        Hashtable ruen = new Hashtable();
        Hashtable enru = new Hashtable();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < ru.Length; i++)
            {
                ruen.Add(ru[i], en[i]);
                if (!enru.ContainsKey(en[i]))
                {
                    enru.Add(en[i], ru1[i]);     
                }
               
            }
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string ruStr;
        string enStr;
        private void button1_Click(object sender, EventArgs e)
        {
            enStr = textBox1.Text;
            char[] enInput = enStr.ToArray();
            char[]ruOut=new char[enInput.Length];
            for (int i = 0; i < enInput.Length; i++)
            {
                if (enru.ContainsKey(enInput[i]))
                {
                    ruOut[i] = (char)enru[enInput[i]];   
                }
                else
                {
                    ruOut[i]=enInput[i];
                }
              
                
            }
            string ru_str = new string(ruOut);
            textBox2.Text = ru_str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruStr = textBox2.Text;
            char[] ruInput = ruStr.ToUpper().ToArray();
            char[] enOut = new char[ruInput.Length];
            for (int i = 0; i < ruInput.Length; i++)
            {
                if (ruen.ContainsKey(ruInput[i]))
                {
                    enOut[i] = (char)ruen[ruInput[i]];

                }
                else
                {
                    enOut[i] = ruInput[i];
                }
            }
            string en_str = new string(enOut);
            textBox1.Text = en_str;
        }
    }
}
