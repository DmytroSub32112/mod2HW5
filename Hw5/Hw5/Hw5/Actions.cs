using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    public class Actions
    {
        private readonly ILogger _logger;

        public Actions(ILogger logger)
        {
            _logger = logger;
        }

        public bool FirstMethod()
        {
            _logger.WriteInfo($"Start {nameof(FirstMethod)}:");
            return true;
        }

        public void SecondMethod()
        {
            throw new BusinessException($"Skipped logic in {nameof(SecondMethod)}:");
        }

        public void ThirdMethod()
        {
            throw new Exception($"I broke a logic in {nameof(ThirdMethod)}");
        }
    }
}
