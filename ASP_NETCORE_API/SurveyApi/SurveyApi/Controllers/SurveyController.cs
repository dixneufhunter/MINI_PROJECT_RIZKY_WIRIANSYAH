using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SurveyApi.Models;
using Newtonsoft.Json;
using SurveyApi.DTO.Response;
using Microsoft.EntityFrameworkCore;

namespace SurveyApi.Controllers
{


    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class SurveyController : ControllerBase
    {

        private readonly ApplicationDbContext_Survey _dbContext;

        public SurveyController(ApplicationDbContext_Survey dbContext) {
            _dbContext = dbContext;
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Survey>>> GetCustomers() {
        //    var data = await _dbContext.Surveys.Include(c => c.Transactions).ToListAsync();
      
        //    return data;

        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lembaga_survey>>> GetSurveys()
        {
            //var data = await _dbContext.lembaga_survey.Include(c => c.ID_LEMBAGA).ToListAsync();
            var data = await _dbContext.lembaga_survey.ToListAsync();

            return data;

        }


        [HttpPost]
        public async Task<IActionResult> CreateSurvey([FromBody] Lembaga_survey newSurvey) {
            if (newSurvey == null) {
                return BadRequest("Data tidak valid");
            }

            try
            {
                _dbContext.lembaga_survey.Add(newSurvey);
                await _dbContext.SaveChangesAsync();
                return Ok(newSurvey);
            }
            catch (DbUpdateException ex) {
                return BadRequest("Gagal menyimpan data : " + ex.Message);
            }
        }

        private bool SurveyExists(int id) {
            return _dbContext.lembaga_survey.Any(survey => survey.ID_LEMBAGA == id);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditSurveyData(int id, Lembaga_survey surveyDataEdit) {
            if (id != surveyDataEdit.ID_LEMBAGA) {
                return BadRequest();
            }

            _dbContext.Entry(surveyDataEdit).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException) {
                if (!SurveyExists(id))
                {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurvey(int id) {
            var survey_ = await _dbContext.lembaga_survey.FindAsync(id);

            if (survey_ == null) {
                return NotFound();
            }

            _dbContext.lembaga_survey.Remove(survey_);

            await _dbContext.SaveChangesAsync();

            return Ok("Data survey berhasil dihapus");
        }

        [HttpGet("id")]
        public async Task<ActionResult<Lembaga_survey>> GetDetailSurvey(int id) {
            var survey_ = await _dbContext.lembaga_survey.FindAsync(id);

            if (survey_ == null) {

                return NotFound("Data survey tidak ditemukan");
            }

            return survey_;
        }


        
      

     
    }
}
