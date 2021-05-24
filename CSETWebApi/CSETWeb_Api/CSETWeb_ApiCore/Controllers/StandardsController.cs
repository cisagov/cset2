﻿//////////////////////////////// 
// 
//   Copyright 2021 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
using System;
using CSETWebCore.Model.Standards;
using Microsoft.AspNetCore.Mvc;
using CSETWebCore.Business.Standards;
using CSETWebCore.Interfaces.Question;
using CSETWebCore.Interfaces.Demographic;
using CSETWebCore.Interfaces.Helpers;
using CSETWebCore.Interfaces.AdminTab;
using CSETWebCore.DataLayer;
using CSETWebCore.Interfaces.Reports;
using System.Collections.Generic;
using CSETWebCore.Model.Question;

namespace CSETWebCore.Api.Controllers
{
    public class StandardsController : ControllerBase
    {
        private readonly ITokenManager _tokenManager;
        private readonly CSETContext _context;
        private readonly IAssessmentUtil _assessmentUtil;
        private IQuestionRequirementManager _questionRequirement;
        private IDemographicBusiness _demographicBusiness;
        private readonly StandardsBusiness _standards;


        public StandardsController(ITokenManager tokenManager, CSETContext context,
             IAssessmentUtil assessmentUtil, IQuestionRequirementManager questionRequirement,
            IDemographicBusiness demographicBusiness)
        {
            _tokenManager = tokenManager;
            _context = context;
            _assessmentUtil = assessmentUtil;
            _questionRequirement = questionRequirement;
            _demographicBusiness = demographicBusiness;
            _standards = new StandardsBusiness(_context, _assessmentUtil, _questionRequirement, _tokenManager,
                _demographicBusiness);
        }

        [HttpGet]
        [Route("api/standards")]
        public StandardsResponse GetStandards()
        {
            int assessmentId = _tokenManager.AssessmentForUser();
            return _standards.GetStandards(assessmentId);
        }


        /// <summary>
        /// Persists the current Standards selection in the database.
        /// </summary>
        [HttpPost]
        [Route("api/standard")]
        public QuestionRequirementCounts PersistSelectedStandards(List<string> selectedStandards)
        {
            int assessmentId = _tokenManager.AssessmentForUser();
            return _standards.PersistSelectedStandards(assessmentId, selectedStandards);
        }

        /// <summary>
        /// Set default standard for basic assessment
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/basicStandard")]
        public QuestionRequirementCounts PersistDefaultSelectedStandards()
        {
            int assessmentId = _tokenManager.AssessmentForUser();
            return _standards.PersistDefaultSelectedStandard(assessmentId);
        }

        /// <summary>
        /// Persists the current Standards selection in the database.
        /// </summary>
        [HttpGet]
        [Route("api/standard/IsFramework")]
        public bool GetFrameworkSelected()
        {
            int assessmentId = _tokenManager.AssessmentForUser();
            return _standards.GetFramework(assessmentId);
        }

        /// <summary>
        /// Persists the current Standards selection in the database.
        /// </summary>
        [HttpGet]
        [Route("api/standard/IsACET")]
        public bool GetACETSelected()
        {
            int assessmentId = _tokenManager.AssessmentForUser();
            return _standards.GetACET(assessmentId);
        }
    }
}
