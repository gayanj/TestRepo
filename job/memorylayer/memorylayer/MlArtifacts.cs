using Mysqllayer;

namespace Memorylayer
{
    public class MlArtifacts
    {
        public void Insertartifacts(string sartifactID, string artifactName, string artifactData)
        {
            var clartifact = new SlArtifacts();
            clartifact.Insertartifacts(sartifactID, artifactName, artifactData);
        }
    }
}