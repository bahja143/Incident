using System.Threading.Tasks;
using Incident.Modal;
using Incident.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Incident.Controllers
{
    [Route("/api/MHCCheck")]
    public class MHCCheckController : Controller
    {
        private IncidentDbContext _context { get; set; }

        public MHCCheckController(IncidentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getAll()
        {
            return Ok(await _context.MHCCheck.Include(m => m.MHC).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getById(int Id)
        {
            return Ok(await _context
                .MHCCheck
                .SingleOrDefaultAsync(c => c.Id == Id));
        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] MHCCheck MHCCheck)
        {
            await _context.MHCCheck.AddAsync(MHCCheck);
            await _context.SaveChangesAsync();

            return Ok(MHCCheck);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> put(int Id, [FromBody] MHCCheck MHCCheck)
        {
            var MHCCheckDb =
                await _context.MHCCheck.SingleOrDefaultAsync(c => c.Id == Id);

            if (MHCCheckDb == null) return NotFound();

            MHCCheckDb.EngineFluidLevelCorrect = MHCCheck.EngineFluidLevelCorrect;
            MHCCheckDb.HydraulicFluidLevelCorrect = MHCCheck.HydraulicFluidLevelCorrect;
            MHCCheckDb.HydraulicSystemExhibitsNoApparentWeepingOrLeaks = MHCCheck.HydraulicSystemExhibitsNoApparentWeepingOrLeaks;
            MHCCheckDb.AirSystemexhibitsNoAudibleLeaks = MHCCheck.AirSystemexhibitsNoAudibleLeaks;
            MHCCheckDb.TyrePressureAccetableAndTireNotDamaged = MHCCheck.TyrePressureAccetableAndTireNotDamaged;
            MHCCheckDb.TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder = MHCCheck.TelescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder;
            MHCCheckDb.WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl = MHCCheck.WireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl;
            MHCCheckDb.ReevingCorrect = MHCCheck.ReevingCorrect;
            MHCCheckDb.WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing = MHCCheck.WedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing;
            MHCCheckDb.AllAndHookAreFreeToSwivelAndRotate = MHCCheck.AllAndHookAreFreeToSwivelAndRotate;
            MHCCheckDb.OutriggerFloatsSecuredWithPadIn = MHCCheck.OutriggerFloatsSecuredWithPadIn;
            MHCCheckDb.Cab = MHCCheck.Cab;
            MHCCheckDb.HandrailsInPlaceAndNotDamaged = MHCCheck.HandrailsInPlaceAndNotDamaged;
            MHCCheckDb.OperatorManualInVehicle = MHCCheck.OperatorManualInVehicle;
            MHCCheckDb.LoadChartLegibleAndVisibleToOperator = MHCCheck.LoadChartLegibleAndVisibleToOperator;
            MHCCheckDb.HandSignalChartVisibleToWorkers = MHCCheck.HandSignalChartVisibleToWorkers;
            MHCCheckDb.ChargedFireExtinguisherInplace = MHCCheck.ChargedFireExtinguisherInplace;
            MHCCheckDb.CabGlassNotCrackedAndWipersAreFunctional = MHCCheck.CabGlassNotCrackedAndWipersAreFunctional;
            MHCCheckDb.LoadMomentIndicatorOperational = MHCCheck.LoadMomentIndicatorOperational;
            MHCCheckDb.DrumRotationIndicatorFunctioning = MHCCheck.DrumRotationIndicatorFunctioning;
            MHCCheckDb.BoomLengthIndicatorFunctioning = MHCCheck.BoomLengthIndicatorFunctioning;
            MHCCheckDb.BoomAngleIndicatorFunctioning = MHCCheck.BoomAngleIndicatorFunctioning;
            MHCCheckDb.EngineHydraulicAirElectricalOilPressureTemperatureAandFuel = MHCCheck.EngineHydraulicAirElectricalOilPressureTemperatureAandFuel;
            MHCCheckDb.CorrectCounterweightForTheLoad = MHCCheck.CorrectCounterweightForTheLoad;
            MHCCheckDb.MainHoistControlFunctioning = MHCCheck.MainHoistControlFunctioning;
            MHCCheckDb.AntiTwoBlockInLaceAndFunctioning = MHCCheck.AntiTwoBlockInLaceAndFunctioning;
            MHCCheckDb.SwingBrake = MHCCheck.SwingBrake;
            MHCCheckDb.AuxiliaryHoistControlFunctioning = MHCCheck.AuxiliaryHoistControlFunctioning;
            MHCCheckDb.DieselFuelLeakage = MHCCheck.DieselFuelLeakage;
            MHCCheckDb.EngineHourMeter = MHCCheck.EngineHourMeter;
            MHCCheckDb.FuelLevelReading = MHCCheck.FuelLevelReading;
            MHCCheckDb.Shift = MHCCheck.Shift;

            await _context.SaveChangesAsync();

            return Ok(MHCCheckDb);
        }
    }
}