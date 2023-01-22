using Artemis.Core.Modules;

namespace Artemis.Plugins.Modules.zero.DataModels;
[Node("zero", "Return bool value", "zero", InputType = typeof(Numeric), OutputType = typeof(bool))]
public class zeroDataModel : node
{
 #region Properties & Fields

    public InputPin<Numeric> Input { get; }
    public OutputPin<bool> Output { get; }

    #endregion

    #region Constructors

    public AbsNumericNode()
    {
        Input = CreateInputPin<Numeric>();
        Output = CreateOutputPin<bool>();
        int previous = '0';
    }

    #endregion

    #region Methods

    /// <inheritdoc />
    public override void Evaluate()
    {
        foreach(int c in Input.value)
    {
        if(c <= previous)
            return Output.value = true;
        previous = c;
    }

     return Output.value = false;
    }

    #endregion
}