using System;
using System.Collections.Generic;
using System.Linq;
using TrackingBlocksAPI.Models;

namespace TrackingBlocksAPI.Repositories
{
  public class BlockRepository : IBlockRepository
  {
    private readonly BlacksContext _context; 
    
    public BlockRepository(BlacksContext context)
    {
      _context = context;
    }

    public void Add(Block block)
    {
      _context.Blocks.Add(block);
      _context.SaveChanges();
    }

    public IEnumerable<Block> GetAll()
    {
      return _context.Blocks.ToList();
    }

    public Block GetBy(int id)
    {
      return _context.Blocks.FirstOrDefault(b => b.Id == id);
    }

    public void Remove(Block block)
    {
      _context.Blocks.Remove(block);
      _context.SaveChanges();
    }

    public void Update(Block block)
    {
      _context.Blocks.Update(block);
      _context.SaveChanges();
    }
  }
}