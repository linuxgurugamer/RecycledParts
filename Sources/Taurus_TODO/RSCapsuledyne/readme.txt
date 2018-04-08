R&S CAPSULDYNE PRESENTS: THE TAURUS HCV AND SERVICE MODULE SYSTEM

TO INSTALL:
	1. Merge GameData folder into KSP Directory.
	2. Enjoy!

Version 1.5.3

	Created by R&S Capsuledyne
	     -Created by bsquiklehausen and jnrobinson

Special thanks to BahamutoD for his wonderful animated engines plug in, and to hoojiwana for brilliant texture advice.

	Planned features:
		-More 3.75m parts to fill in the form factor gaps
		-RPM prop for the TVs

CHANGELOG
v 1.5.3 (7/1/15)
-Changed researchTime and researchMultiplier in the Science Bay to integer values

v 1.5.2 (6/28/15)
-Adjusted thrust and ISP values of engines to match changes in 1.0.3
-Adjusted science production values to be more similar to stock
-Adjusted heatshield config to match changes in 1.0.3

v 1.5.1 (5/25/15)
-Fixed thrust and Isp values of both engines
-Capsule and heatshield aerodynamics adjusted so they no longer tumble on reentry
-Science bay should now properly shield parts inside cargo bays
-Updated included bdanimationmodules.dll
-Taurus escape engines can no longer be turned off (sorry, had to do this to fix a bug with the effects not showing properly)
	-Thrust of Taurus engines can now be adjusted through tweakables

v 1.5.0 (4/27/15)
-Added new part: a 3.75 m nuclear engine with four gimballing bells and fairing
-Added new part: a 3.75 m ore tank for stock ISRU system
-Added internal view for Science Lab
-Updated parts config files to include information for stock aerodynamics and heating
-Rebalances for the Quadroodle and fuel tank to fit stock closer
-Updated science bay to include new lab mechanics and new aero support
-Updated heat shield for stock ablator and aero - now matches stock 3.75m shield
-Removed TACLS from Taurus Config to allow for other LS mods to be used
-Fixed Quadroodle collision mesh bugs
-Added launch surface FX to Quadroodle

v 1.4.0 (12/15/14)
-Added new part: a 3.75 m reaction wheel unit with a 2.5 m battery inside
-Modified some textures to get ever closer to that stock look
-Modified LES to allow for shutting down of escape engines if accidentally fired
-Fixed a typo on the heatshield texture. TIL 'Capsuledyne" has two 'e's
-Cleaned up Unity materials used, may cause performance gains, may not, who knows
-Introduced KNOWN BUG: the engine sinks through the launchpad, even though it has a proper (functional) collider (let us know if you can help!)
	-Just don't use the Quadroodle as a launch engine - it's not good at that anyway

v 1.3.0 (10/6/14)
-Added new part: a 3.75 m orbital engine with fairing
-Added new part: a 3.75 m 8-Kerbal hitchhiker with interior
-Modified all textures for every part
-Modified ALL textures for every part (too much work for a single changelog line!)
-Moved parts around the tech tree to spread everything out for career mode, parts now distributed across several nodes in the last tier
-Changed part costs and entry costs for several parts. Should be reasonable in-line now
-Actually balanced LES thrust much more
-Converted SolidFuel LES boosters to MonoPropellant so you don't have to lug SolidFuel through the solar system. We can pretend the LES is now an abort program that can't be stopped, it that makes you happy.
-Removed alternateConfig as ExtraplanetaryLaunchpads should now be compatible
-Changed name of Science Processing Bay to allow FAR/NEAR compatibility
-Updated Science Bay to use new stock animation module, removed Firespitter.dll from download as it is no longer needed
-Removed many bump maps as new alpha-channel speculars made them too much overhead for a small gain
-Removed specific specular maps, replaced by alpha-channel speculars
-Converted textures to .mbms. We're sorry, but it reduces aliasing from far away.

v 1.2.1.1 (7/24/14)
-Removed flags folder since the R&S flag is now in the agencies folder

v 1.2.1 (7/22/14)

-Updated firespitter.dll to 0.24 compatible version
-Added R&S Capsuledyne as an in game Agency


v 1.2 (7/17/14)
-Added new part: a 3.75 m combination science lab and storage bay (with doors!)
-Added new part: a 3.75 m slim stack separator (dual-sided decoupler)
-Modified textures on heatshield fairing
-Balanced cost values for new parts
-NOTE: Science bay requires firespitter.dll to use doors in VAB

CHANGELOG:
v 1.1.1 (7/8/14)
-HOTFIX: Fixed compatibility issues with RPM .17
-Continuing to modify engine thrust transform placement in an attempt to fix phantom torque issues

v 1.1 (6/9/14)
-Added heatshield, fully DRE and FAR compatible, with fairing
-LES thrust is now centered, will no longer create sideways torque
-Removed useless/ugly structural members from interior
-Added specular effects to windows in exterior view
-Slightly modified interior textures
-Slightly modified exterior textures
-Laid foundation for light-up windows (coming soon)
-Updated to latest version of the AnimationModules plugin

v 1.0.1 (4/20/14)
-Hotfix: moved the ModuleManager config file out of the folder to prevent issues where ModuleManager would try to load the RPM internal but fail if RPM wasn't installed. You now have to manually add the patch file if you want the RPM props.

v 1.0 (4/20/14)
-Added interiors
-Added flag decal
-Added RPM support for interiors

v 0.6 (4/15/14)
-Updated external textures to be more stock-y
-Fixed LES pieces disappearing when zoomed in too far
-Boosted capacity to 7 in preparation for upcoming IVAs
-Increased dry mass to 7.5 units (tons? metric tons? slug?)
-Took steps to alleviate FAR-based asymmetric drag issue, which occurs because FAR includes the collision mesh for the ladder and the hatch in it's aerodynamic calculations; Ferram has informed me this will likely be fixed in an upcoming version of FAR
-Attempted to fix Kerbals flying of ladders/doing a 360-no-scope when exiting the hatch
-Changed license to be more lenient

v 0.5.2 (4/7/14)
-Included modified part file without engine config for those who were having compatibility issues (possibly with extraplanetary launchpads)

v 0.5.1 (4/4/14)
-Actually included the standard textures. Whoops

v 0.5 (4/4/14)
-Initial release

Please do not distribute without asking permission first. 
Also, if you charge someone for this download, you're a butt.

License: Distributed under BY-SA 3.0
https://creativecommons.org/licenses/by-sa/3.0/