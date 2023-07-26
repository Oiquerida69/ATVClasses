namespace ATVClasses
{
    public partial class Form1 : Form
    {
         List<Modelo> Modelos = new List<Modelo>();
        public Form1()
        {
            InitializeComponent();
        }

        
        

        
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            string nome = txt_Nome.Text;
            int idade = int.Parse(txt_Idade.Text);
            string rua = txt_Rua.Text;
            string cidade = txt_Cidade.Text;
            Modelo modelo = new Modelo(nome,idade,rua,cidade);
            Modelos.Add(modelo);
            AtualizaInterface();
            



        }
        public void AtualizaInterface()
        {
            list_View1.Clear();
            for (int i = 0; i < Modelos.Count; i++)
            {
                list_View1.Items.Add($"{Modelos[i].nome} - {Modelos[i].idade} - {Modelos[i].endereço} - {Modelos[i].cidade} ");
            }
        } 
    }
}