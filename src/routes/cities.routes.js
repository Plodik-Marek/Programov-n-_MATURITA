import express from "express";

import * as citiesController from "../controllers/cities.controller.js";

const router = express.Router();
router.get("/", citiesController.getCities);
router.get("/:id", citiesController.getCity);

export default router;
