class Journal
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string JournalFile = "Journal.txt";

    public static List<Journal> journal = new List<Journal>();

        public static void DisplayJournal()
    {
        foreach (Journal entry in journal)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }
}
