using WebAPI.Dtos.Weapon;

namespace WebAPI.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterResponseDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
