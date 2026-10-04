namespace ParkMinDev.UPM.SQLite.Toolkit
{
	public interface ISQLiteRecord<TKey>
	{
		TKey Id { get; }
	}
}
