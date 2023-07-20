using GymReport.Common.Entities;
using GymReport.DAL.Contexts;
using GymReport.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace GymReport.DAL.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly DbContextBase _context;
        public ExerciseRepository(DbContextBase context)
        {
            _context = context;
        }
        public Exercise AddExercise(Exercise exercise)
        {
            _context.Exercises.Add(exercise);
            _context.SaveChanges();
            return exercise;
        }

        public void Delete(Exercise exercise)
        {
            _context.Exercises.Remove(exercise);
            _context.SaveChanges();
        }

        public async Task<List<Exercise>> GetAllExercises()
        {
            return await _context.Exercises.ToListAsync();
        }

        public Exercise GetById(int id)
        {
            return _context.Exercises.FirstOrDefault(e => e.Id == id);
        }
    }
}
