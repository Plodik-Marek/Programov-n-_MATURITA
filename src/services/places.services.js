import * as placesRepository from "../repostiroies/places.repository.js";

export async function getPlaces() {
  return await placesRepository.getPlaces();
}

export async function getPlace(id) {
  return await placesRepository.getPlace(id);
}

export async function addPlace(place) {
  return await placesRepository.addPlace(place);
}

export async function updatePlace(id, data) {
  return await placesRepository.updatePlace(id, data);
}

export async function deletePlace(id) {
  return await placesRepository.deletePlace(id);
}

export async function getPlacesByCity(cityId) {
  return await placesRepository.getPlacesByCity(cityId);
}