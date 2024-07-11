import { Route, Routes } from "react-router-dom";
import Login from "./auth/Login";
import Register from "./auth/Register";
import { AuthorizedRoute } from "./auth/AuthorizedRoute";
import { Home } from "./Home";
import { UserProfileList } from "./userProfiles/UserProfileList";
import { UserProfileDetails } from "./userProfiles/UserProfileDetails";

export default function ApplicationViews({ loggedInUser, setLoggedInUser }) {
  return (
    <Routes>
      <Route path="/">
        <Route
          index
          element={
            <AuthorizedRoute loggedInUser={loggedInUser}>
              <Home />
            </AuthorizedRoute>
          }
        />
        <Route path="userprofiles">
          <Route
            index
            element={
              <AuthorizedRoute roles={["Admin"]} loggedInUser={loggedInUser}>
                <UserProfileList />
              </AuthorizedRoute>
            }
          />
          <Route
            path={":id"}
            element={
              <AuthorizedRoute roles={["Admin"]} loggedInUser={loggedInUser}>
                <UserProfileDetails />
              </AuthorizedRoute>
            }
          />
        </Route>

        <Route
          path="login"
          element={<Login setLoggedInUser={setLoggedInUser} />}
        />
        <Route
          path="register"
          element={<Register setLoggedInUser={setLoggedInUser} />}
        />
      </Route>
    </Routes>
  );
}
