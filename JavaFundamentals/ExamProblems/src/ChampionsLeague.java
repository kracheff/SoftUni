import java.util.*;
import java.util.Comparator;

public class ChampionsLeague {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String initialInput = sc.nextLine();
        boolean isNotStop = initialInput != "stop";
        String[] input = initialInput.split("\\b \\| \\b");

        TreeMap<String, List<String>> teamsAndOpponents = new TreeMap<>();
        List<String> opponent = new ArrayList<>();

        TreeMap<String, Integer> teamsAndWins = new TreeMap<>();

        int team1Wins = 0;
        int team2Wins = 0;

        while (isNotStop) {

            String team1 = input[0];
            String team2 = input[1];

            String[] firstGameScore = input[2].split(":");
            String[] secondGameScore = input[3].split(":");

            int team1HomeGoals = Integer.parseInt(firstGameScore[0]);
            int team1AwayGoals = Integer.parseInt(secondGameScore[1]);
            int team2HomeGoals = Integer.parseInt(secondGameScore[0]);
            int team2AwayGoals = Integer.parseInt(firstGameScore[1]);

            if (teamsAndOpponents.get(team1) == null) {
                opponent = new ArrayList<>();
                opponent.add(team2);
                Collections.sort(opponent);
                teamsAndOpponents.put(team1, opponent);
            } else if (!teamsAndOpponents.get(team1).contains(team2)) {
                opponent = teamsAndOpponents.get(team1);
                opponent.add(team2);
                Collections.sort(opponent);
                teamsAndOpponents.put(team1, opponent);
            }

            if (teamsAndOpponents.get(team2) == null) {
                opponent = new ArrayList<>();
                opponent.add(team1);
                Collections.sort(opponent);
                teamsAndOpponents.put(team2, opponent);
            } else if (!teamsAndOpponents.get(team2).contains(team1)) {
                opponent = teamsAndOpponents.get(team2);
                opponent.add(team1);
                Collections.sort(opponent);
                teamsAndOpponents.put(team2, opponent);
            }

            boolean isTeam1Winner = team1HomeGoals + team1AwayGoals > team2HomeGoals + team2AwayGoals;
            boolean isTeam2Winner = team1HomeGoals + team1AwayGoals < team2HomeGoals + team2AwayGoals;
            boolean areEqualGoals = team1HomeGoals + team1AwayGoals == team2HomeGoals + team2AwayGoals;
            boolean isTeam1WinnerIfEqualGoals = team1AwayGoals > team2AwayGoals;
            boolean isTeam2WinnerIfEqualGoals = team1AwayGoals < team2AwayGoals;

            if (isTeam1Winner || (areEqualGoals && isTeam1WinnerIfEqualGoals)) {
                if (teamsAndWins.get(team1) == null) {
                    team1Wins = 0;
                } else {
                    team1Wins = teamsAndWins.get(team1);
                }
                teamsAndWins.put(team1, team1Wins + 1);
                if (teamsAndWins.get(team2) == null) {
                    teamsAndWins.put(team2, 0);
                }

            } else if (isTeam2Winner || (areEqualGoals && isTeam2WinnerIfEqualGoals)) {
                if (teamsAndWins.get(team2) == null) {
                    team2Wins = 0;
                } else {
                    team2Wins = teamsAndWins.get(team2);
                }
                teamsAndWins.put(team2, team2Wins + 1);
                if (teamsAndWins.get(team1) == null) {
                    teamsAndWins.put(team1, 0);
                }
            }

            initialInput = sc.nextLine();
            isNotStop = !initialInput.equals("stop");
            input = initialInput.split("\\b \\| \\b");
        }

        ArrayList<Integer> wins = new ArrayList<>();
        for (Integer win : teamsAndWins.values()) {
            if (wins == null || !wins.contains(win)) {
                wins.add(win);
            }
        }
        Collections.sort(wins);

        for (int i = wins.size() - 1; i >= 0; i--) {
            for (Map.Entry<String, Integer> team : teamsAndWins.entrySet()) {
                if (wins.get(i) == team.getValue()) {
                    System.out.println(team.getKey());
                    System.out.println("- Wins: " + wins.get(i));
                    System.out.printf("- Opponents: %s\n", String.join(", ", teamsAndOpponents.get(team.getKey())));
                }
            }

        }

//        System.out.println(teamsAndWins);
//        System.out.println(teamsAndOpponents);

        sc.close();
    }
}
