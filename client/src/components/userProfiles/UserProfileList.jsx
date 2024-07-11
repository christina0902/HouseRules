import { getUserProfiles } from "../../managers/userProfileManager";
import { useState, useEffect } from "react";
import { Table, Button } from "reactstrap";
import { useNavigate, useParams } from "react-router-dom";

export const UserProfileList = () => {
  const [userProfiles, setUserProfiles] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    getUserProfiles().then((arr) => setUserProfiles(arr));
  }, []);

  return (
    <>
      <h1>UserProfiles</h1>
      <Table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {userProfiles.map((up) => (
            <tr key={up.id}>
              <th scope="row">{`${up.firstName} ${up.lastName}`}</th>
              <td>
                <Button
                  color="success"
                  onClick={() => {
                    navigate(`/userprofiles/${up.id}`);
                  }}
                >
                  See Details
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </>
  );
};
