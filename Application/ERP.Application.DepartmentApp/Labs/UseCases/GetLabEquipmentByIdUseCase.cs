using ERP.Application.DepartmentApp.Labs.Interfaces;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Labs.UseCases
{
    public class GetLabEquipmentByIdUseCase : IGetLabEquipmentByIdUseCase
    {
        private readonly ILabRepository _labRepository;

        public GetLabEquipmentByIdUseCase(ILabRepository labRepository)
        {
            _labRepository = labRepository;
            
        }
        public async Task ExecuteAsync(int id)
        {
            await _labRepository.GetLabEquipmentById(id);
        }
    }
}
