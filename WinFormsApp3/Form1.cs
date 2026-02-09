namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Queue<string> fila = new Queue<string>();
        Stack<string> pilha = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtnPilha_Click(object sender, EventArgs e)
        {
            pilha.Push(textPilha.Text);
            AtualizarPilha();
        }

        private void RmBtnPilha_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 0)
            {
                pilha.Pop();
                AtualizarPilha();
            }
        }

        private void AtualizarPilha()
        {
            LbxPilha.Items.Clear();
            foreach (string item in pilha)
            {
                LbxPilha.Items.Add(item);
            }
        }

        private void AddBtnFila_Click(object sender, EventArgs e)
        {
            fila.Enqueue(textFila.Text);
            AtualizarFila();
        }

        private void RmBtnFila_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
            {
                fila.Dequeue();
                AtualizarFila();
            }
        }

        private void AtualizarFila()
        {
            LbxFila.Items.Clear();
            foreach (string item in fila)
            {
                LbxFila.Items.Add(item);
            }
        }
    }
}
