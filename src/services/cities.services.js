import * as citiesRepository from "../repostiroies/cities.repository.js";

export async function getCities() {
  return await citiesRepository.getCities();
}

export async function getCity(id) {
  return await citiesRepository.getCity(id);
}
