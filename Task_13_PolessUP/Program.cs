string version1 = "2.5.34.1.2";
string version2 = "2.5.34";
Console.WriteLine(Version1Version2Compare(version1, version2));

int Version1Version2Compare(string version1, string version2)
{
    string[] group1 = version1.Split('.');
    string[] group2 = version2.Split('.');
    int count = 0;
    if (group1.Length > group2.Length)
        count = group1.Length;
    else count = group2.Length;

    for (int index = 0; index < count; index++)
    {

        int temp1 = 0;
        int temp2 = 0;

        try
        {
            if (index < group1.Length)
                temp1 = int.Parse(group1[index]);

            if (index < group2.Length)
                temp2 = int.Parse(group2[index]);
        } 
        catch (Exception)
        {
            return 0;
        }

        if (temp1 > temp2)
        {
            return 1;
        }
        else if (temp1 < temp2)
        {
            return -1;
        }
    }


    return 0;
}
