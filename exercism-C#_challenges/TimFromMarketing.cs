using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null && department == null && name != null) 
            return String.Format("{0} - OWNER", name);
        if (department == null && name != null && id != null) 
            return String.Format("[{0}] - {1} - OWNER", id, name);
        if (id == null && name != null && department != null) 
            return String.Format("{0} - {1}", name, department.ToUpper());
        return String.Format("[{0}] - {1} - {2}", id, name, department.ToUpper());
    }
}
