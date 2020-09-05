﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReaiotBackend.IRepositories;
using ReaiotBackend.Models.FreeLearnModels;

namespace ReaiotBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class SettingController : BaseController<Setting>
    {
        public SettingController(ISettingRepository settingRepository) : base(settingRepository)
        {

        }
    }
}
