import * as raitingsRepository from "../repostiroies/raitings.repository.js";

export async function getRaitings() {
  return await raitingsRepository.getRaitings();
}

export async function getRaiting(id) {
  return await raitingsRepository.getRaiting(id);
}

export async function addRaiting(raitings) {
  await raitingsRepository.addRaiting(raitings);
}

export async function updateRaiting(id, newData) {
  await raitingsRepository.updateRaiting(id, newData);
}

export async function deleteRaiting(id) {
  await raitingsRepository.deleteRaiting(id);
}


export async function getRaitingsByPlace(placeId) {
  return await raitingsRepository.getRaitingsByPlace(placeId);
}

export async function getAverageRaitingByPlace(placeId) {
  return await raitingsRepository.getAverageRaitingByPlace(placeId);
}