namespace BookmarksStocker.Source.QO
{
    /* Query Object Class */
    internal class Crud
    {

        internal static string GetIdentityQuery()
        {
            return "SELECT @@IDENTITY As IdCol;";
        }

    }
}
