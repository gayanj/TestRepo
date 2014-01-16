using Memorylayer;

namespace Msftlayer
{
    public class ClArtifacts
    {
        public void Insertartifacts(string sartifactId, string artifactName, string artifactData)
        {
            var mlartifact = new MlArtifacts();
            mlartifact.Insertartifacts(sartifactId, artifactName, artifactData);
        }
    }
}