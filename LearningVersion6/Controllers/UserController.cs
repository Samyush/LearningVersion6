using LearningVersion6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningVersion6.Controllers;

public class UserController : Controller
{
    private readonly Year3DbContext _year3DbContext;

    public UserController(Year3DbContext db)
    {
        _year3DbContext = db;
    }
    
    public async Task<IActionResult> Try()
    {
        //implementation of stored procedure
        var salesList = _year3DbContext.Sales.FromSqlRaw($"FirstStoredProcdure").ToList();
        return Ok("is working fine " + salesList);
    }
    
    // GET
    public ActionResult Index()
    {
        var userList = _year3DbContext.Users.ToArray();

        return Ok(userList);
    }

    
    //the below method will give 405 error while running or hitting through web browser
    [HttpPost]
    [Route("adding")]
    public async Task<ActionResult<User>> AddingUsers([FromBody]User users)
    {
        
            var userData = new User
            {
                ID = 0,
                Email = users.Email,
                Name = users.Name,
                PhoneNumber = users.PhoneNumber
            };
            
            _year3DbContext.Users.Add(userData);
            var result = await _year3DbContext.SaveChangesAsync();
            return Ok(result);

        //return Ok("Failed");
    }
    
    [HttpPost]
    [Route("addingSecondWay")]
    public async Task<ActionResult<User>> AddingUsersSecondWay(User users, int Id, string Email, string Name, string PhoneNumber)
    {
        users.ID = 0;
        users.Email = Email;
        users.Name = users.Name;
        users.PhoneNumber = users.PhoneNumber;
            
        _year3DbContext.Users.Add(users);
        var result = await _year3DbContext.SaveChangesAsync();
        return Ok(result);

        //return Ok("Failed");
    }
    
    public async Task<ActionResult> Delete(int id)
    {
        var toDel = _year3DbContext.Users.Where(x => x.ID == id).First();
        _year3DbContext.Users.Remove(toDel);
        var result = await _year3DbContext.SaveChangesAsync();
        return Ok(toDel + " Delete Success");
    }
   
}