static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        //"[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"
        if(id == null)
        {
            return $"{name} - {department?.ToUpper()??"OWNER"}";
        }
        return $"[{id}] - {name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
