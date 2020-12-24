using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public interface IFileWorkView
    {
        event Action<string> LoadHumanGenerationStrategy;
        event Action<string> LoadLiftConfigurationStrategy;
        event Action<string> SaveHumanGenerationStrategy;
        event Action<string> SaveLiftConfigurationStrategy;
        public void setFilter(string filter);
    }
}
