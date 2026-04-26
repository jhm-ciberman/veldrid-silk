namespace NeoVeldrid.OpenGL.NoAllocEntryList;

internal struct NoAllocPushConstantsEntry
{
    public readonly uint OffsetInBytes;
    public readonly StagingBlock StagingBlock;
    public readonly uint StagingBlockSize;

    public NoAllocPushConstantsEntry(uint offsetInBytes, StagingBlock stagingBlock, uint stagingBlockSize)
    {
        OffsetInBytes = offsetInBytes;
        StagingBlock = stagingBlock;
        StagingBlockSize = stagingBlockSize;
    }
}
