namespace Todo_LocalAuth_API_GUI.models
{
    public class Todo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool Completed { get; set; }

        public string Deadline { get; set; }

        public string AnzeigeName
        {
            get
            {
                string erledigt;
                if (Completed)
                {
                    erledigt = "Ja";
                }
                else
                {
                    erledigt = "Nein";
                }

                if (Deadline != "NO DATE ADDED")
                {
                    return Name + ", Erledigt: " + erledigt + ", Deadline: " + Deadline;
                }
                else
                {
                    return Name + ", Erledigt: " + erledigt;
                }

            }   
        }
    }
}
