using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebapiEVO.Data;
using WebapiEVO.Models;
using WebapiEVO.ViewModels;

namespace WebapiEVO.Controllers
{   
    [ApiController]
    [Route("v1")]
    public class DepartamentoController : ControllerBase
    {
        // GET
        [HttpGet]
        [Route("departamento/{id}")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDataContext context,
            [FromRoute] int id)
        {
            var Departamento = await context//AppDataContext
                .Departamentos
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == id);

            return Departamento == null
                ? NotFound()
                : Ok(Departamento);
        }

        [HttpPost("departamento")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDataContext context,
            [FromBody] CreateDepartamentoViewModels Model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var Departamento = new Departamento
            {
                ID = Model.ID,
                Nome = Model.Nome,
                Sigla = Model.Sigla,
            };

            try
            {
                await context.Departamentos.AddAsync(Departamento);
                await context.SaveChangesAsync();
                return Created("v1/todos/{departamento.ID}", Departamento);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }

        [HttpPut("departamento/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDataContext context,
            [FromBody] CreateDepartamentoViewModels Model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var departamento = await context
            .Departamentos
            .FirstOrDefaultAsync(x => x.ID == id);

            if (departamento == null)
                return NotFound();

            try
            {
                departamento.ID = Model.ID;
                departamento.Nome = Model.Nome;
                departamento.Sigla = Model.Sigla;

                context.Departamentos.Update(departamento);
                await context.SaveChangesAsync();
                return Ok(departamento);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }   

        }

         [HttpDelete("departamento/{id}")]
         public async Task<IActionResult> DeleteAsync(
             [FromServices] AppDataContext context,
             [FromRoute] int id)
         {
             var departamento = await context
             .Departamentos
             .Include(p => p.Funcionarios)
             .Where(x => x.ID == id)
             .FirstOrDefaultAsync(x => x.ID == id);

             try
             {
                 context.Departamentos.Remove(departamento);
                 await context.SaveChangesAsync();

                 return Ok();
             }
             catch (System.Exception)
             {
                 return BadRequest();
             }
         }

        [HttpGet]
        [Route("departamento/")]
        public async Task<IActionResult> GetAllDepartamentosAsync(
            [FromServices] AppDataContext context)
        {
            var Departamento = await context//AppDataContext
                .Departamentos
                .AsNoTracking()
                .ToListAsync();

            return Departamento == null
                ? NotFound()
                : Ok(Departamento);
        }

         [HttpGet]
         [Route("departamento/func/{id}")]
         public async Task<IActionResult> GetFuncionarioAsyncDepartamento(
             [FromServices] AppDataContext context,
             [FromRoute] int id)
         {
             var departamento = await context//AppDataContext
                 .Funcionarios
                 .Where(x => x.DepartamentoID == id)
                 .AsNoTracking()
                 .ToListAsync();
             return departamento == null
                 ? NotFound()
                 : Ok(departamento);
         }
         
    }
    [Route("v1")]
    public class FuncionarioController : ControllerBase
    {
        // GET
        [HttpGet]
        [Route("funcionario/{id}")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDataContext context,
            [FromRoute] int id)
        {
            var Funcionario = await context//AppDataContext
                .Funcionarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == id);

            return Funcionario == null
                ? NotFound()
                : Ok(Funcionario);
        }

        [HttpPost("funcionario")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDataContext context,
            [FromBody] CreateFuncionarioViewModels Model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var Funcionario = new Funcionario
            {
                Nome = Model.Nome,
                RG = Model.RG,
                Foto = Model.Foto,
                DepartamentoID = Model.DepartamentoID,
            };

            try
            {
                await context.Funcionarios.AddAsync(Funcionario);
                await context.SaveChangesAsync();
                return Created("v1/todos/{funcionario.ID}", Funcionario);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }

        [HttpPut("funcionario/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDataContext context,
            [FromBody] CreateFuncionarioViewModels Model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var funcionario = await context
            .Funcionarios
            .FirstOrDefaultAsync(x => x.ID == id);

            if (funcionario == null)
                return NotFound();

            try
            {
                funcionario.Nome = Model.Nome;
                funcionario.RG = Model.RG;
                funcionario.Foto = Model.Foto;
                funcionario.DepartamentoID = Model.DepartamentoID;

                context.Funcionarios.Update(funcionario);
                await context.SaveChangesAsync();
                return Ok(funcionario);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }   

        }

         [HttpDelete("funcionario/{id}")]
         public async Task<IActionResult> DeleteAsync(
             [FromServices] AppDataContext context,
             [FromRoute] int id)
         {
             var funcionario = await context
             .Funcionarios
             .Where(x => x.ID == id)
             .FirstOrDefaultAsync(x => x.ID == id);

             try
             {
                 context.Funcionarios.Remove(funcionario);
                 await context.SaveChangesAsync();

                 return Ok();
             }
             catch (System.Exception)
             {
                 return BadRequest();
             }
         }

         [HttpGet]
         [Route("funcionario/")]
         public async Task<IActionResult> GetFuncionariosAsync(
             [FromServices] AppDataContext context)
         {
             var funcionarios = await context//AppDataContext
                 .Funcionarios
                 .AsNoTracking()
                 .ToListAsync();
             return funcionarios == null
                 ? NotFound()
                 : Ok(funcionarios);
         }
    }
}