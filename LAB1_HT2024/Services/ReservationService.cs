using LAB1_HT2024.Models;
using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Models.ViewModels;
using LAB1_HT2024.Services.IServices;
using LAB1_HT2024.Models.DTOs.ReservationDTOs;
using LAB1_HT2024.Data.Repository;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace LAB1_HT2024.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ITableRepository _tableRepository;

        public ReservationService(IReservationRepository reservationRepository, ITableRepository tableRepository)
        {
            _reservationRepository = reservationRepository;
            _tableRepository = tableRepository;
        }

        public async Task<IEnumerable<ReservationViewModel>> GetAllReservations()
        {
            var GetReservationList = await _reservationRepository.GetAllReservations();

            return GetReservationList.Select(r => new ReservationViewModel
            {
                ReservationId = r.Id,
                CustomerId = r.CustomerId_FK,
                groupSize = r.GroupSize,
                TableId = r.TableId_FK,
                reservationStart = r.ReservationStart,
                reservationEnd = r.ReservationEnd
            }).ToList();
        }

        public async Task<ReservationViewModel> GetReservationById(int ReservationId)
        {
            var GetReservation = await _reservationRepository.GetReservationById(ReservationId);

            return new ReservationViewModel
            {
                ReservationId = GetReservation.Id,
                CustomerId = GetReservation.CustomerId_FK,
                groupSize = GetReservation.GroupSize,
                TableId = GetReservation.TableId_FK,
                reservationEnd = GetReservation.ReservationEnd,
                reservationStart = GetReservation.ReservationStart
            };
        }

        public async Task RemoveReservation(int ReservationId)
        {
            var GetReservation = await _reservationRepository.GetReservationById(ReservationId);

            await _reservationRepository.RemoveReservation(GetReservation);
        }

        public async Task UpdateReservation(ReservationDTO updateReservationDTO)
        {
            var reservation = await _reservationRepository.GetReservationById(updateReservationDTO.ReservationId);
            {
                reservation.CustomerId_FK = updateReservationDTO.CustomerId;
                reservation.GroupSize = updateReservationDTO.groupSize;
                reservation.TableId_FK = updateReservationDTO.TableId;
                reservation.ReservationEnd = updateReservationDTO.reservationEnd;
                reservation.ReservationStart = updateReservationDTO.reservationStart;
            }

            await _reservationRepository.UpdateReservation(reservation);
        }

        public async Task AddReservation(CreateReservationDTO createReservationDTO)
        {
            var AvailableTables = await _tableRepository.GetAvailableTables(createReservationDTO.groupSize, createReservationDTO.reservationStart);

            var NewReservation = new Reservation
            {
                CustomerId_FK = createReservationDTO.CustomerId,
                TableId_FK = createReservationDTO.TableId,
                GroupSize = createReservationDTO.groupSize,
                ReservationEnd = createReservationDTO.reservationEnd,
                ReservationStart = createReservationDTO.reservationStart
            };

            await _reservationRepository.AddReservation(NewReservation);
        }
    }
}

