List<string> list = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .ToList();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] lines = input.Split();
    string command = lines[0];
    string phoneModel = lines[2];
    if (command == "Add")
    {
        if (list.Contains(phoneModel))
        {
            continue;
        }
        else
        {
            list.Add(phoneModel);
        }
    }
    else if (command == "Remove")
    {
        if (list.Contains(phoneModel))
        {
            list.Remove(phoneModel);
        }
        else { continue; }
    
    }
    else if (command == "Bonus")
    {
        string newP = lines[3];
        string[] newPhoneModel1 = newP.Split(":");
        string oldM = newPhoneModel1[0];
        string newModel = newPhoneModel1[1];
        if (list.Contains(oldM))
        {
            int index = list.IndexOf(oldM);
            int indexNewM = index + 1;
            list.Insert(indexNewM, newModel);
        }
    }
    else if (command == "Last")
    {
        if (list.Contains(phoneModel))
        {
            string a = phoneModel;
            list.Remove(phoneModel);
            list.Add(a);
        }
    }
}
Console.WriteLine(string.Join(", ",list)) ;
/*
HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiaomiNote:Iphone5
End
*/