using Action.Core.ActionDecorators;
using Action.Core.Models;
using Action.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Action.Core.TemplateAction
{
    [ClassDecorator(Name = "Custom Template Action", Shape = ActionShape.Circle, Description = "Custom Template Action Description", Category =Category.CAT_1)]
    [FEDecorator(Label = "Configuration Modal", Type = FeComponentType.Modal, Parent = "Config_Modal", Tab ="Input Tab")]
    public sealed class CustomTemplateAction : IAction
    {
        #region Options
        private IEnumerable<OptionModel> ConfigP1Options { get; } = new List<OptionModel>() 
        { 
            new OptionModel()
            {
                Name = "Option 1",
                Value = "Value for option 1"
            },
            new OptionModel(){
                Name = "Option 2",
                Value = "Value for option 2"
            }
        };
        private IEnumerable<OptionModel> ConfigP2Options { get; } = new List<OptionModel>()
        {
            new OptionModel()
            {
                Name = "Option 3",
                Value = "Value for option 3"
            },
            new OptionModel(){
                Name = "Option 4",
                Value = "Value for option 4"
            }
        };
        #endregion

        #region Properties
        [FEDecorator(Label = "FE Input property", Type = FeComponentType.Select, Tab = "Input Tab")]
        [BEDecorator(IOProperty = Direction.Input)]
        [Validator(IsRequired = false)]
        public string Input1 { get; set; }

        [FEDecorator(Label = "FE Output property", Type = FeComponentType.Number, Tab = "Output Tab")]
        [BEDecorator(IOProperty = Direction.Output)]
        [Validator(IsRequired = true, Expects = ExpectedType.Number)]
        public int Output1 { get; set; }

        [FEDecorator(Label = "FE Config property 1", Type = FeComponentType.Select, Parent = "Config_Modal", Options = "ConfigP1Options")]
        [BEDecorator(IOProperty = Direction.Output)]
        public string OutConfig1 { get; set; }

        [FEDecorator(Label = "FE Config property 2", Type = FeComponentType.Select, Parent = "Config_Modal", Options = "ConfigP2Options")]
        [BEDecorator(IOProperty = Direction.Output)]
        public string OutConfig2 { get; set; }
        #endregion

        #region Execute
        public Task Execute()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
