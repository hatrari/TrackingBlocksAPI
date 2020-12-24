using System;
using System.Collections.Generic;
using TrackingBlocksAPI.Models;

namespace TrackingBlocksAPI.Repositories
{
  public interface IBlockRepository
  {
    void Add(Block block);
    IEnumerable<Block> GetAll();
    Block GetBy(int id);
    void Remove(Block block);
    void Update(Block block);
  }
}