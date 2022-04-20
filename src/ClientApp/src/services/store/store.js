import { configureStore } from "@reduxjs/toolkit";
import theme from "../reducers/themeSlice";

export default configureStore({
  reducer: {
      theme:theme,
  },
});