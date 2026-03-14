namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] block = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock(),
        };
    }
}
