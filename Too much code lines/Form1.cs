namespace Too_much_code_lines
{
  public partial class Form1 : Form
  {
    private List<Personne> fausseBD;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CreationFausseBD();
      foreach(Personne person in fausseBD)
        AjoutPersonneDansListBox(person);
      MajAgeMoyen();
    }

    private void AjoutPersonneDansListBox(Personne person)
    {
      lbPersonne.Items.Add(person.Nom + " " + person.Prenom + " (" + person.Age + " ans)");
    }

    private void MajAgeMoyen()
    {
      int AgeMoy = 0;
      foreach(var item in fausseBD)
      {
        AgeMoy += item.Age;
      }
      AgeMoy /= fausseBD.Count;
      tbAgeMoy.Text = AgeMoy.ToString();
    }

    private void CreationFausseBD()
    {
      fausseBD = new List<Personne>();
      fausseBD.Add(
        new Personne("Largo", "Winch", 26));
      fausseBD.Add(
        new Personne("Simon", "Ovronnaz", 26));
      fausseBD.Add(new Personne("Dracula", "Alucard", 666));
    }

    private void bAjouter_Click(object sender, EventArgs e)
    {
      Personne NouvPers = new Personne(tbNom.Text, tbPrenom.Text, int.Parse(tbAge.Text));
      fausseBD.Add(NouvPers);
      AjoutPersonneDansListBox(NouvPers);
      MajAgeMoyen();
    }
  }

  public class Personne
  {
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }
    public Personne(string nom, string prenom, int age)
    {
      Nom = nom;
      Prenom = prenom;
      Age = age;
    }
  }
}
