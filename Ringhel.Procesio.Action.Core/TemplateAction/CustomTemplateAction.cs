using Ringhel.Procesio.Action.Core;
using Ringhel.Procesio.Action.Core.ActionDecorators;
using Ringhel.Procesio.Action.Core.Utils;
using System;
using System.Threading.Tasks;

namespace TestAction
{
    [ClassDecorator(Name = "Custom Template Action", Shape = ActionShape.Circle, Description = "Custom Template Action Description", Classification = Classification.CAT_1)]
    [FEDecorator(Label = "Configuration Modal", Type = FeComponentType.Modal, Parent = "Config_Modal", Tab = "Input Tab")]
    public class MyCustonAction : IAction
    {

        #region Options
        private const string ConfigP1Options = "[{\"Name\":\"my name1\",\"Value\":\"1\"},{\"Name\":\"my name2\",\"Value\":\"2\"},{\"Name\":\"my name3\",\"Value\":\"3\"}]";
        private const string ConfigP2Options = "[{\"Name\":\"my name3\",\"Value\":\"my name value 3\"},{\"Name\":\"my name4\",\"Value\":\"my name value 4\"}]";
        #endregion

        #region Properties
        [FEDecorator(Label = "FE Input property", Type = FeComponentType.Select, Tab = "Input Tab", Options = "ConfigP1Options")]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input1 { get; set; }

        [FEDecorator(Label = "FE Input property", Type = FeComponentType.Number, Tab = "Input Tab", DefaultValue = "0")]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public int Input2 { get; set; }

        [FEDecorator(Label = "FE Output property", Type = FeComponentType.Number, Tab = "Output Tab", DefaultValue = "2")]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = true, Expects = ExpectedType.Number)]
        public int Output1 { get; set; }

        [FEDecorator(Label = "FE Config property 2", Type = FeComponentType.Select, Parent = "Config_Modal", Options = "ConfigP2Options")]
        [BEDecorator(IOProperty = Direction.Output)]
        public string OutConfig2 { get; set; }
        #endregion

        #region Execute
        public async Task Execute()
        {
            Output1 = Input1 + Input2;
        }
        #endregion
    }
}
