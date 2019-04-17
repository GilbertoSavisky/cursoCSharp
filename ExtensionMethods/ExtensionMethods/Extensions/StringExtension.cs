namespace System
{ 
    static class StringExtension
    {
        public static string Cut(this string thisObjt, int count)
        {
            if (thisObjt.Length <= count)
                return thisObjt;
            else
                return thisObjt.Substring(0, count) + "...";
        }
    }
}
