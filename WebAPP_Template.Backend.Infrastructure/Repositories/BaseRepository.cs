using WebAPP_Template.Backend.Infrastructure.Context;

namespace WebAPP_Template.Backend.Infrastructure.Repositories
{
	public abstract class BaseRepository
	{
		protected MyContext _ctx;
		protected BaseRepository(MyContext ctx)
		{
			_ctx = ctx;
		}
	}
}
