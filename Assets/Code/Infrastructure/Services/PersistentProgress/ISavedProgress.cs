using Code.Data;

namespace Code.Infractructure.Services.PersistentProgress
{
	public interface ISavedProgress : ISavedProgressReader
	{
		void UpdateProgress(PlayerProgress progress);
	}

	public interface ISavedProgressReader
	{
		void LoadProgress(PlayerProgress progress);
	}
}

