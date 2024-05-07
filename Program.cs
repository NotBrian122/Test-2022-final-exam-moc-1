namespace Test_papers_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($" {"#",-10} {"Eircode",-10} {"Rent",-10} {"Eligible",-10} {"Bed Spaces",-10} {"Cost per bed Rates",-10}");
            //Question 1

            Propertiy prop = new Propertiy("d913k5", 1400, 3);
            Console.WriteLine(prop.ToString());

            CommercialProperty prop2 = new CommercialProperty("d913k5", 1000, 2,'A');
            Console.WriteLine(prop2.ToString());
            //Question2

            string Path = "../../../baseText.txt";

            using StreamReader sr = new StreamReader(Path);
            string[] List =sr.ReadToEnd().Split(',', '\r', '\n');
            try
            {

                for (int i = 0; i < List.Length; i += 4)
                {
                    if (List[0 + i].Length == 6 && int.TryParse(List[1 + i], out int rent) && int.TryParse(List[2 + i], out int bedSpace))
                    {
                        Propertiy propApp = new Propertiy(List[0 + i], rent, bedSpace);
                        Console.WriteLine(propApp.ToString());

                    }
                    else if (List[0 + i].Length == 6 && int.TryParse(List[1 + i], out rent) && int.TryParse(List[2 + i], out bedSpace) && bedSpace == null && char.TryParse(List[3 + i], out char rating ))
                    {
                        CommercialProperty compProp = new CommercialProperty(List[0 + i], rent, bedSpace, rating);
                        Console.WriteLine(compProp.ToString());
                    }
                    else
                    {
                        throw new ArgumentException("This shit aint working");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
