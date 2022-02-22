﻿using DIMS_Core.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace DIMS_Core.Tests.TestsContext
{
    public static class ContextCreator
    {
        public static DimsContext CreateContext()
        {
            var options = GetOptions();

            return new DimsContext(options);
        }

        private static DbContextOptions<DimsContext> GetOptions()
        {
            var builder = new DbContextOptionsBuilder<DimsContext>().UseInMemoryDatabase(GetInMemoryDbName());

            return builder.Options;
        }

        private static string GetInMemoryDbName() => $"InMemory_{Guid.NewGuid()}";
    }
}