using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrackingBlocksAPI.Repositories;
using TrackingBlocksAPI.Models;

namespace TrackingBlocksAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BlocksController : ControllerBase
  {
    private readonly IBlockRepository _blocksRepo;
    
    public BlocksController(IBlockRepository blockRepo)
    {
      _blocksRepo = blockRepo;
    }

    [HttpGet]
    public IEnumerable<Block> Get()
    {
      return _blocksRepo.GetAll();
    }
    
    [HttpPost]
    public Block Post([FromBody] Block block)
    {
      _blocksRepo.Add(block);
      return block;
    }

    [HttpPut]
    public Block Put([FromBody] Block block)
    {
      _blocksRepo.Update(block);
      return block;
    }

    [HttpDelete]
    public Block Delete([FromBody] Block block)
    {
      _blocksRepo.Remove(block);
      return block;
    }
  }
}