using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/mccheck")]
    public class MCCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public MCCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.MCCheck.Include(m => m.MC).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .MCCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] MCCheck MCCheck)
        {
            await _context.MCCheck.AddAsync(MCCheck);
            await _context.SaveChangesAsync();

            return Ok(MCCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] MCCheck MCCheck)
        {
            var MHCCheckDb =
                await _context.MCCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (MHCCheckDb == null) return NotFound();

            MHCCheckDb.EngineFluidLevelCorrect = MCCheck.EngineFluidLevelCorrect;
            MHCCheckDb.HydraulicFluidLevelCorrect = MCCheck.HydraulicFluidLevelCorrect;
            MHCCheckDb.HydraulicSystemExhibitsNoApparentWeepingOrLeaks = MCCheck.HydraulicSystemExhibitsNoApparentWeepingOrLeaks;
            MHCCheckDb.AirSystemexhibitsNoAudibleLeaks = MCCheck.AirSystemexhibitsNoAudibleLeaks;
            MHCCheckDb.TyrePressureAccetableAndTireNotDamaged = MCCheck.TyrePressureAccetableAndTireNotDamaged;
            MHCCheckDb.TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder = MCCheck.TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder;
            MHCCheckDb.WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl = MCCheck.WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl;
            MHCCheckDb.ReevingCorrect = MCCheck.ReevingCorrect;
            MHCCheckDb.WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing = MCCheck.WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing;
            MHCCheckDb.AllAndHookAreFreeToSwivelAndRotate = MCCheck.AllAndHookAreFreeToSwivelAndRotate;
            MHCCheckDb.OutriggerFloatsSecuredWithPadIn = MCCheck.OutriggerFloatsSecuredWithPadIn;
            MHCCheckDb.Cab = MCCheck.Cab;
            MHCCheckDb.HandrailsInPlaceAndNotDamaged = MCCheck.HandrailsInPlaceAndNotDamaged;
            MHCCheckDb.OperatorManualInVehicle = MCCheck.OperatorManualInVehicle;
            MHCCheckDb.LoadChartLegibleAndVisibleToOperator = MCCheck.LoadChartLegibleAndVisibleToOperator;
            MHCCheckDb.HandSignalChartVisibleToWorkers = MCCheck.HandSignalChartVisibleToWorkers;
            MHCCheckDb.ChargedFireExtinguisherInplace = MCCheck.ChargedFireExtinguisherInplace;
            MHCCheckDb.CabGlassNotCrackedAndWipersAreFunctional = MCCheck.CabGlassNotCrackedAndWipersAreFunctional;
            MHCCheckDb.LoadMomentIndicatorOperational = MCCheck.LoadMomentIndicatorOperational;
            MHCCheckDb.DrumRotationIndicatorFunctioning = MCCheck.DrumRotationIndicatorFunctioning;
            MHCCheckDb.BoomLengthIndicatorFunctioning = MCCheck.BoomLengthIndicatorFunctioning;
            MHCCheckDb.BoomAngleIndicatorFunctioning = MCCheck.BoomAngleIndicatorFunctioning;
            MHCCheckDb.EngineHydraulicAirElectricalOilPressureTemperatureAandFuel = MCCheck.EngineHydraulicAirElectricalOilPressureTemperatureAandFuel;
            MHCCheckDb.CorrectCounterweightForTheLoad = MCCheck.CorrectCounterweightForTheLoad;
            MHCCheckDb.MainHoistControlFunctioning = MCCheck.MainHoistControlFunctioning;
            MHCCheckDb.AntiTwoBlockInLaceAndFunctioning = MCCheck.AntiTwoBlockInLaceAndFunctioning;
            MHCCheckDb.SwingBrake = MCCheck.SwingBrake;
            MHCCheckDb.AuxiliaryHoistControlFunctioning = MCCheck.AuxiliaryHoistControlFunctioning;
            MHCCheckDb.DieselFuelLeakage = MCCheck.DieselFuelLeakage;
            MHCCheckDb.Shift = MCCheck.Shift;
            MHCCheckDb.EngineHourMeter = MCCheck.EngineHourMeter;
            MHCCheckDb.FuelLevelReading = MCCheck.FuelLevelReading;
            MHCCheckDb.Shift = MCCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(MHCCheckDb);
        }
    }
}