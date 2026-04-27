import express from "express";
import cors from "cors";

import citiesRoutes from "./routes/cities.routes.js";
import placesRoutes from "./routes/places.routes.js";
import reviewsRoutes from "./routes/reviews.routes.js";
import raitingsRoutes from "./routes/raitings.routes.js";

const app = express();

app.use(cors());
app.use(express.json());

app.use("/cities", citiesRoutes);
app.use("/places", placesRoutes);
app.use("/reviews", reviewsRoutes);
app.use("/raitings", raitingsRoutes);

app.use((req, res) => {
  res.send(
    "Welcome to ExploreCity use / cities, /places, /reviews or /ratings to access the data",
  );
});

app.listen(3000, () => {
  console.log("Server is running on port http://localhost:3000");
});
