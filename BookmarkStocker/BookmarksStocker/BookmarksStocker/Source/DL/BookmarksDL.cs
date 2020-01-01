using Net.Light.Framework.Entity.Base;
using Net.Light.Framework.Entity.QueryBuilding;
using Net.Light.Framework.Logic.BaseDal;
using Net.Light.Framework.Logic.Extensions;
using System;

namespace BookmarksStocker.Source.DL
{
    internal class BookmarksDL : BaseDL
    {
        internal BookmarksDL()
            : base("sqlce")
        {
        }

        public override int InsertAndGetId(BaseBO baseBO)
        {
            try
            {
                int insertResult = base.Insert(baseBO);
                if (insertResult == 1)
                {
                    QueryBuilder qB = CreateQueryBuilder(QueryTypes.Identity, baseBO);
                    insertResult = ExecuteScalarAsQuery(qB.QueryString).ToInt();
                }
                else
                {
                    insertResult = 0;
                }

                return insertResult;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}