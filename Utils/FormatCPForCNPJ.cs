namespace SIGNA.Utils
{
    public class FormatCPForCNPJ
    {
        public string Format(string cpf)
        {
            string formattedCpf = cpf;

            if(formattedCpf.Length == 14)
            {
                formattedCpf = formattedCpf.Insert(2, ".");
                formattedCpf = formattedCpf.Insert(6, ".");
                formattedCpf = formattedCpf.Insert(10, "/");
                formattedCpf = formattedCpf.Insert(15, "-");
            }

            if(formattedCpf.Length == 11)
            {
                formattedCpf = formattedCpf.Insert(3, ".");
                formattedCpf = formattedCpf.Insert(7, ".");
                formattedCpf = formattedCpf.Insert(11, "-");
            }

            return formattedCpf;
        }
    }
}
